public class Moneytrade{
    public static double Cal1000(double Money){
    return Money%1000;
 }
 public static double Cal500(double M1000){
    return M1000%500;
 }
 public static double Cal100(double M500){
    return M500%100;
 }
 public static double Cal50(double M100){
    return M100%50;
 }
 public static double Cal20(double M50){
    return M50%20;
 }
 public static double Cal10(double M20){
    return M20%10;
 }
 public static double Cal5(double M10){
    return M10%5;
 }
 public static double Cal2(double M5){
    return M5%2;
 }
 public static double Cal1(double M2){
    return M2%1;
 }
 public static double Cal_50(double M1){
    return M1%0.5;
 }
 public static double Cal_25(double M_50){
    return M_50*100%0.25;
 }


 public static int trade1000(double Money){
    return (int)Money/1000;
 }
 public static int trade500(double M1000){
    return (int)M1000/500;
 }
public static int trade100(double M500){
    return (int)M500/100;
 }
 public static int trade50(double M100){
    return (int)M100/50;
 }
 public static int trade20(double M50){
    return (int)M50/20;
 }
 public static int trade10(double M20){
    return (int)M20/10;
 }
 public static int trade5(double M10){
    return (int)M10/5;
 }
 public static int trade2(double M5){
    return (int)M5/2;
 }
public static int trade1(double M2){
    return (int)M2/1;
 }
 public static int trade_50(double M1){
    return (int)(M1/0.5);
 }
 public static int trade_25(double M_50){
    return (int)(M_50/0.25);
 }
}