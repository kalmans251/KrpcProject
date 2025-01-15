using System;
using System.Net;
using CustomLib;
using KRPC.Client;
using KRPC.Client.Services.KRPC;
using KRPC.Client.Services.SpaceCenter;


class Program {
    public static void Main() {
        using (var connection = new Connection(name: "My Example Program",address: IPAddress.Parse("127.0.0.1"),rpcPort: 50000,streamPort: 50001)) {

            var spaceCenter= connection.SpaceCenter();

            var vessel = spaceCenter.ActiveVessel;
            var body = spaceCenter.Bodies;
            var e_nrRF = body["Kerbin"].NonRotatingReferenceFrame;
            var e_rRF = body["Kerbin"].ReferenceFrame;    
            var flight = vessel.Flight(e_rRF);
            var control = vessel.Control;

            var pid1 = new Cpid(0,0.06,0,1000,0,0);
            var pid2 = new Cpid(0.1,0.01,0.1,1,0,1);

            var ut_stream = connection.AddStream(() => spaceCenter.UT); // stream에 등록
            double prev_T=ut_stream.Get();
            while(!control.Abort){
                double dt;
                lock(ut_stream.Condition){ // KSP 물리연산이 발생할때 까지 정지 
                    if(ut_stream.Get()-prev_T == 0){
                        ut_stream.Wait();
                    }
                    dt = ut_stream.Get()-prev_T;
                    prev_T=ut_stream.Get();
                }
                var target1=pid1.runPid((float)(500-flight.MeanAltitude),dt);
                control.Throttle= (float)pid2.runPid((float)(target1-flight.MeanAltitude),dt);

                Console.WriteLine(target1);
            }


            control.Abort =false;












        }
    }
}