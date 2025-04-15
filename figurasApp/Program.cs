using System;

interface IFigura
{
    public double calcularArea();
    public double calcularPerimetro();
}

public class Rectangulo : IFigura{
    private double baseFigura;
    private double altura;

    public Rectangulo(double baseFigura, double altura)
    {
        this.baseFigura = baseFigura;
        this.altura = altura;
    }

    public double calcularArea(){
        return baseFigura * altura;
    }

    public double calcularPerimetro(){
        return 2 * (baseFigura + altura);
    }

}

public class Cuadrado : IFigura{
    private double lado;

    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    public double calcularArea(){
        return lado * lado;
    }

    public double calcularPerimetro(){
        return 4 * lado;
    }

}

public class Triangulo : IFigura{
    private double baseFigura;
    private double altura;

    public Triangulo(double baseFigura, double altura)
    {
        this.baseFigura = baseFigura;
        this.altura = altura;
    }

    public double calcularArea(){
        return (baseFigura * altura) / 2;
    }

    public double calcularPerimetro(){
        return 2 * (baseFigura + altura);
    }

}

public class Circulo : IFigura{
    private double radio;
    private double PI = 3.14;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double calcularArea(){
        return PI * radio * radio;
    }
    public double calcularPerimetro(){
        return 2 * PI * radio;
    }
}


public class Program
{
    public static void Main()
    { 
        string[] figuras = { "Rectangulo", "Cuadrado", "Triangulo", "Circulo" };
        for (int i = 0; i < figuras.Length; i++)
        {
            Console.WriteLine("Ingrese la base del " + figuras[i]);
            double baseFigura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del " + figuras[i]);
            double altura = Convert.ToDouble(Console.ReadLine());

            switch (figuras[i])
            {
                case "Rectangulo":
                    Rectangulo = new Rectangulo(baseFigura, altura);
                    break;
                case "Cuadrado":
                    Cuadrado = new Cuadrado(baseFigura);
                    break;
                case "Triangulo":
                    Triangulo = new Triangulo(baseFigura, altura);
                    break;
                case "Circulo":
                    Circulo = new Circulo(baseFigura);
                    break;
            }
            Console.WriteLine("El area del Rectangulo es: " + figuras[i].calcularArea());
            Console.WriteLine("El perimetro del Rectangulo es: " + figuras[i].calcularPerimetro());
        }
    }
}