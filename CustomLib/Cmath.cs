
namespace CustomLib;

public class Cmath
{
    public static Tuple<double,double,double> addVector(Tuple<double,double,double> a,Tuple<double,double,double> b){
        return Tuple.Create<double,double,double> (a.Item1+b.Item1,a.Item2+b.Item2,a.Item3+b.Item3);
    }

    public static Tuple<double,double,double> subVector(Tuple<double,double,double> a,Tuple<double,double,double> b){
        return Tuple.Create<double,double,double> (a.Item1-b.Item1,a.Item2-b.Item2,a.Item3-b.Item3);
    }

    public static Tuple<Tuple<double,double,double>,Tuple<double,double,double>,Tuple<double,double,double>> multMatrix(double a,Tuple<Tuple<double,double,double>,Tuple<double,double,double>,Tuple<double,double,double>> b){
        return Tuple.Create<Tuple<double,double,double>,Tuple<double,double,double>,Tuple<double,double,double>> (Tuple.Create<double,double,double>(a*b.Item1.Item1,a*b.Item1.Item2,a*b.Item1.Item3),Tuple.Create<double,double,double>(a*b.Item2.Item1,a*b.Item2.Item2,a*b.Item2.Item3),Tuple.Create<double,double,double>(a*b.Item3.Item1,a*b.Item3.Item2,a*b.Item3.Item3));
    }

    public static Tuple<double,double,double> multMatrix(double a,Tuple<double,double,double> b){
        return Tuple.Create<double,double,double> (a*b.Item1,a*b.Item2,a*b.Item3);
    }

    public static Tuple<double,double,double> multMatrix(Tuple<Tuple<double,double,double>,Tuple<double,double,double>,Tuple<double,double,double>> a,Tuple<double,double,double> b){
        return Tuple.Create<double,double,double> (a.Item1.Item1*b.Item1+a.Item1.Item2*b.Item2+a.Item1.Item3*b.Item3,a.Item2.Item1*b.Item1+a.Item2.Item2*b.Item2+a.Item2.Item3*b.Item3,a.Item3.Item1*b.Item1+a.Item3.Item2*b.Item2+a.Item3.Item3*b.Item3);
    }

    public static Tuple<Tuple<double,double,double>,Tuple<double,double,double>,Tuple<double,double,double>> multMatrix(Tuple<Tuple<double,double,double>,Tuple<double,double,double>,Tuple<double,double,double>> a,Tuple<Tuple<double,double,double>,Tuple<double,double,double>,Tuple<double,double,double>> b){
        return Tuple.Create<Tuple<double,double,double>,Tuple<double,double,double>,Tuple<double,double,double>> (Tuple.Create<double,double,double> (a.Item1.Item1*b.Item1.Item1+a.Item1.Item2*b.Item2.Item1+a.Item1.Item3*b.Item3.Item1,a.Item1.Item1*b.Item1.Item2+a.Item1.Item2*b.Item2.Item2+a.Item1.Item3*b.Item3.Item2,a.Item1.Item1*b.Item1.Item3+a.Item1.Item2*b.Item2.Item3+a.Item1.Item3*b.Item3.Item3),Tuple.Create<double,double,double> (a.Item2.Item1*b.Item1.Item1+a.Item2.Item2*b.Item2.Item1+a.Item2.Item3*b.Item3.Item1,a.Item2.Item1*b.Item1.Item2+a.Item2.Item2*b.Item2.Item2+a.Item2.Item3*b.Item3.Item2,a.Item2.Item1*b.Item1.Item3+a.Item2.Item2*b.Item2.Item3+a.Item2.Item3*b.Item3.Item3),Tuple.Create<double,double,double> (a.Item3.Item1*b.Item1.Item1+a.Item3.Item2*b.Item2.Item1+a.Item3.Item3*b.Item3.Item1,a.Item3.Item1*b.Item1.Item2+a.Item3.Item2*b.Item2.Item2+a.Item3.Item3*b.Item3.Item2,a.Item3.Item1*b.Item1.Item3+a.Item3.Item2*b.Item2.Item3+a.Item3.Item3*b.Item3.Item3));
    }

    public static Tuple<double,double,double> createMatrix(double a1,double a2,double a3){
        return Tuple.Create<double,double,double> (a1,a2,a3);
    }

    public static Tuple<Tuple<double,double,double>,Tuple<double,double,double>,Tuple<double,double,double>> createMatrix(double a1,double a2,double a3,double a4,double a5,double a6,double a7,double a8,double a9){
        return Tuple.Create<Tuple<double,double,double>,Tuple<double,double,double>,Tuple<double,double,double>> (Tuple.Create<double,double,double>(a1,a2,a3),Tuple.Create<double,double,double>(a4,a5,a6),Tuple.Create<double,double,double>(a7,a8,a9));
    }

    public static Tuple<double,double,double,double> createQuaternion(double p,double q,double r,double w){
        return Tuple.Create<double,double,double,double> (p,q,r,w);
    }

    public static Tuple<double,double,double,double> multQuaternion(Tuple<double,double,double,double> q1,Tuple<double,double,double,double> q2){
        return Tuple.Create<double,double,double,double> (q1.Item1*q2.Item4+q1.Item4*q2.Item1-q1.Item3*q2.Item2+q1.Item2*q2.Item3,q1.Item2*q2.Item4+q1.Item3*q2.Item1+q1.Item4*q2.Item2-q1.Item1*q2.Item3,q1.Item3*q2.Item4-q1.Item2*q2.Item1+q1.Item1*q2.Item2+q1.Item4*q2.Item3,q1.Item4*q2.Item4-q1.Item1*q2.Item1-q1.Item2*q2.Item2-q1.Item3*q2.Item3);
    }
    
    public static Tuple<double,double,double,double> reverseQuaternion(double p,double q,double r,double w){
        return Tuple.Create<double,double,double,double> (-p,-q,-r,w);
    }

    public static Tuple<Tuple<double,double,double>,Tuple<double,double,double>,Tuple<double,double,double>> createScrewSym(double w1,double w2,double w3,bool isLeftRef=true){
        if (isLeftRef){
        return Tuple.Create<Tuple<double,double,double>,Tuple<double,double,double>,Tuple<double,double,double>>  (Tuple.Create<double,double,double>(0,w3,-w2),Tuple.Create<double,double,double>(-w3,0,w1),Tuple.Create<double,double,double>(w2,-w1,0));
        }else{
        return Tuple.Create<Tuple<double,double,double>,Tuple<double,double,double>,Tuple<double,double,double>>  (Tuple.Create<double,double,double>(0,-w3,w2),Tuple.Create<double,double,double>(w3,0,-w1),Tuple.Create<double,double,double>(-w2,w1,0));
        }
    }



}
