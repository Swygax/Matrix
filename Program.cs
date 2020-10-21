using System;

namespace Matrix
{
  class Program
  {
    public static void Main(string[] args)
    {
      Matrix A = new Matrix();
      A.name = "A";
      A.make();


      Matrix B = new Matrix();
      B.name = "B";
      B.make();

      A.show();

      B.show();

      //Matrix AB = new Matrix();
      //AB.add(A,B, "S");

      Matrix PAB = new Matrix();
      PAB.mult(A, B, "Produto AB");
    }
  }
}
