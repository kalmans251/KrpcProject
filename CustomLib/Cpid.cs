namespace CustomLib;

public class Cpid{

    private double Kp=0;
    private double Ki=0;
    private double Kd=0;
    private double p=0;
    private double i=0;
    private double d=0;
    private double outMax=1;
    private double outMin=-1;
    private double prev_error=0;
    private double pidOut=0;
    private double lowPassFilter = 1;

    public Cpid(double Kp,double Ki,double Kd,double outMax,double outMin,double lowPassFilter){
        this.Kp=Kp;
        this.Ki=Ki;
        this.Kd=Kd;
        this.outMax=outMax;
        this.outMin=outMin;
        this.lowPassFilter=lowPassFilter;
    }

    public void setPid(double Kp,double Ki,double Kd,double outMax,double outMin,double lowPassFilter){
        this.Kp=Kp;
        this.Ki=Ki;
        this.Kd=Kd;
        this.outMax=outMax;
        this.outMin=outMin;
        this.lowPassFilter=lowPassFilter;
    }

    public double runPid(double error,double dt){
        p=Kp*error;
        if (pidOut > outMax & error >= 0){
        }else if (pidOut < outMin & error <= 0){
        }else{
            i+=Ki*error*dt;
        }
        d+=lowPassFilter*(Kd*(error-prev_error)/dt-d);
        prev_error=error;
        pidOut=p+i+d;
        return pidOut;
    }

}