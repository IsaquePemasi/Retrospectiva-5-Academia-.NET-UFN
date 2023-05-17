using ConsoleApp1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal interface IFormaGeometrica
    {
        double CalcularArea();
        double CalcularPerimetro();
    }
}
//8 - Interface "IFormaGeometrica"
//Crie uma interface chamada "IFormaGeometrica" com dois métodos abstratos: "CalcularArea()" e "CalcularPerimetro()". Em seguida, crie duas classes que implementam essa interface: "Retangulo" e "Circulo". Implemente os métodos "CalcularArea()" e "CalcularPerimetro()" para cada uma dessas classes, de forma que o "Retangulo" calcule a área e o perímetro de um retângulo e o "Circulo" calcule a área e o perímetro de um círculo.Por fim, crie uma lista de "IFormaGeometrica" contendo um objeto "Retangulo" e um objeto "Circulo", e chame os métodos "CalcularArea()" e "CalcularPerimetro()" para cada um dos objetos.