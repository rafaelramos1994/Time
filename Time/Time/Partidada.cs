using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTime
{
    class Partida
    {
        private DateTime data;
        private ClasseTime timeCasa;
        private ClasseTime timeVisitante;
        private int placarCasa;
        private int placarVisitante;

        public Partida(DateTime dataPartida,ClasseTime Tcasa,ClasseTime Tvisitante)
        {
            this.data = dataPartida;
            this.timeCasa = Tcasa;
            this.timeVisitante = Tvisitante;
            this.placarCasa = 0;
            this.placarVisitante = 0;
        }

        public int golCasa()
        {
            return placarCasa++;
        }
        public int golVisitante()
        {
            return placarVisitante++;
        }

        public string getPlacar()
        {
            if (this.placarCasa > this.placarVisitante)
            {
                this.timeCasa.Vitorias = 1;
                this.timeVisitante.Derrotas = 1;
                return "O vencedor da partidade em " + this.data.ToString("dd-MM-yyyy") +
                    " entre " + this.timeCasa.Nome +
                    " x " + this.timeVisitante.Nome +
                    " foi o time " + this.timeCasa.Nome +
                    " com o placar de " + this.placarCasa.ToString() +
                    " a " + this.placarVisitante.ToString() + ".";
            }
            if(this.placarCasa == this.placarVisitante)
            {
                this.timeCasa.Empates = 1;
                this.timeVisitante.Empates = 1;
                return "Sem vencedor na partidade em " + this.data.ToString("dd-MMM-yyyy") +
                    " com o placar de " + this.placarCasa + " a " +
                    this.placarVisitante;
            }

            this.timeCasa.Derrotas = 1;
            this.timeVisitante.Vitorias = 1;
            return "O vencedor da partidade em " + this.data.ToString("dd-MM-yyyy") +
                " entre " + this.timeCasa.Nome +
                " x " + this.timeVisitante.Nome +
                " foi o time " + this.timeVisitante.Nome +
                " com o placar de " + this.placarVisitante.ToString() +
                " a " + this.placarCasa.ToString() + ".";
        }
        public void  jogar(ClasseTime tim1,ClasseTime tim2)
        {
            Console.WriteLine("Jogando..");
            for(int i = 0; i < 9; i++)
            {
                golCasa();
            }
            golVisitante();

            tim1.gol(3);
            tim1.gol(5);
            tim1.gol(6);
            tim1.gol(6);
            tim1.gol(6);
            tim1.gol(7);
            tim1.gol(7);
            tim1.gol(9);
            tim1.gol(11);

            tim2.gol(1);
            Console.ReadKey();
            Console.WriteLine("Total de gols "+ (placarCasa+placarVisitante));
        }
    }
}
