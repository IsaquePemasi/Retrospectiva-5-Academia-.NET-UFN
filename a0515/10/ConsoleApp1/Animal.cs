﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}

//3 - Crie uma classe Animal com propriedades Nome e Idade. Em seguida, crie as classes Cachorro e Gato que herdam de Animal e adicionam uma propriedade Raca.