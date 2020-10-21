using System;

namespace Matrix{
  class Matrix{
    public string name;
    public int line, column;
    public double[,] matrix;

    // matrix constructor
    public void make(){
      Console.WriteLine("\nMatrix {0}", this.name);
      Console.Write("Enter the number of rows in the matrix: ");
      this.line = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter the number of columns in the matrix: ");
      this.column = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("The order or type of the matrix {0} is ({1} by {2})", this.name, this.line.ToString(), this.column.ToString());

      this.matrix = new double [this.line, this.column];
      for (int i=0; i < this.line; i++){
        for (int j=0; j < this.column; j++){
          Console.Write("{0}) {1}, {2} =  ",this.name, i+1, j+1);
          this.matrix[i,j] = Convert.ToDouble(Console.ReadLine());
        }
      }
    }
    
    // function to show the matrix on the screen
    public void show(){
      Console.WriteLine("Matrix {0}", this.name);
      for (int i=0; i < this.line; i++){
        Console.WriteLine("");
        for (int j=0; j < this.column; j++){
          Console.Write("\t{0},{1}:[\t{2} ]", i+1, j+1, matrix[i,j]);
        }
        Console.WriteLine("");
      }
    }


    public void mk(int x, int y, String name){
      this.line = x;
      this.column = y;
      this.name = name;
      this.matrix = new double [this.line, this.column];
    }

    public void add(Matrix x, Matrix y, String name){
      mk(x.line, y.column, name);
      if(x.line != y.line && x.column != y.column){
        Console.WriteLine("Error: The order or type of the matrix is different!");
        return;
      }
      for (int i=0; i < x.line; i++){
        for (int j=0; j < y.column; j++){
          this.matrix[i,j] = x.matrix[i,j] + y.matrix[i,j];
        }
      }
      this.show();
    }


    public void mult(Matrix x, Matrix y, String name){
      double acumula=0;
      mk(x.line, y.column, name);
      if(x.column != y.line){
        Console.WriteLine("Error: these matrix is not able to multiply");
        return;
      }
      for(int i=0; i < x.line; i++){
        for(int j=0; j < y.column; j++){
          for(int k=0; k < y.line; k++){
            acumula = acumula + x.matrix[i,k] * y.matrix[k,j];
          }
          this.matrix[i,j] = acumula;
          acumula=0;
        }
      }
      this.show();
    }
  }
}
