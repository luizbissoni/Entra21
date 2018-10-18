using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    public class Popular
    {
        static Popular()
        {
            Program.professores.Add(new Professor()
            {
                NomeProfessor = "Vitór Martins Santos",
                SexoProfessor = "Masculino",
                CPFProfessor = "321.503.454-98",
                RGProfessor = "37.689.617-6",
                TurnoProfessor = "Matutino",
                NacionalidadeProfessor = "Brasil",
                NascimentoProfessor = new DateTime(1944 / 07 / 16),
                EspecialidadeProfessor = "Matemática",
                NumeroContaSalarioProfessor = 200476,
                NumeroAgenciaContaSalarioProfessor = 2246,
                CEPProfessor = "26063-180",
                UFProfessor = "Rio de Janeiro",
                NumeroCasaProfessor = 33,
                EmailProfessor = "vitorMartinsSantos@dayrep.com",
                ComplementoProfessor = ""
            });
            Program.professores.Add(new Professor()
            {
                NomeProfessor = "Camila Gomes Goncalves",
                SexoProfessor = "Feminino",
                CPFProfessor = "542.195.124-38",
                RGProfessor = "48.807.911-1",
                TurnoProfessor = "Noturno",
                NacionalidadeProfessor = "Brasil",
                NascimentoProfessor = new DateTime(1996 / 04 / 28),
                EspecialidadeProfessor = "Física",
                NumeroContaSalarioProfessor = 477852,
                NumeroAgenciaContaSalarioProfessor = 0305,
                CEPProfessor = "66083-497",
                UFProfessor = "Pará",
                NumeroCasaProfessor = 949,
                EmailProfessor = "camilaGomesGoncalves@armyspy.com",
                ComplementoProfessor = ""
            });
            Program.professores.Add(new Professor()
            {
                NomeProfessor = "Fábio Goncalves Gomess",
                SexoProfessor = "Masculino",
                CPFProfessor = "354.699.442-63",
                RGProfessor = "15.787.257-9",
                TurnoProfessor = "Vespertino",
                NacionalidadeProfessor = "Brasil",
                NascimentoProfessor = new DateTime(1964 / 05 / 24),
                EspecialidadeProfessor = "Física",
                NumeroContaSalarioProfessor = 620725,
                NumeroAgenciaContaSalarioProfessor = 5008,
                CEPProfessor = "94852-040",
                UFProfessor = "RS",
                NumeroCasaProfessor = 528,
                EmailProfessor = "FabioGoncalvesGomes@rhyta.com",
                ComplementoProfessor = ""
            });
            Program.professores.Add(new Professor()
            {
                NomeProfessor = "Daniel Alves Gomes",
                SexoProfessor = "Masculino",
                CPFProfessor = "474.482.463-30",
                RGProfessor = "33.701.756-6",
                TurnoProfessor = "Noturno",
                NacionalidadeProfessor = "Brasil",
                NascimentoProfessor = new DateTime(1970 / 12 / 23),
                EspecialidadeProfessor = "Portugues",
                NumeroContaSalarioProfessor = 546817,
                NumeroAgenciaContaSalarioProfessor = 5559,
                CEPProfessor = "72140-100",
                UFProfessor = "Taguatinga",
                NumeroCasaProfessor = 1126,
                EmailProfessor = "DanielAlvesGomes@jourrapide.com",
                ComplementoProfessor = ""
            });
            Program.professores.Add(new Professor()
            {
                NomeProfessor = "Thaís Cardoso Barros",
                SexoProfessor = "Feminino",
                CPFProfessor = "114.053.693-10",
                RGProfessor = "24.100.330-1",
                TurnoProfessor = "Vespertino",
                NacionalidadeProfessor = "Brasil",
                NascimentoProfessor = new DateTime(1994 / 11 / 07),
                EspecialidadeProfessor = "Ingles",
                NumeroContaSalarioProfessor = 976284,
                NumeroAgenciaContaSalarioProfessor = 6617,
                CEPProfessor = "74356-008",
                UFProfessor = "GO",
                NumeroCasaProfessor = 1149,
                EmailProfessor = "ThaisCardosoBarros@teleworm.us",
                ComplementoProfessor = ""
            });
            Program.funcionarios.Add(new Funcionario() 
            { 
                NomeFuncionario = "",
                SexoFuncionario ="",
                

            
            
            });

        }
    }
}
