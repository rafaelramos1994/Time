using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTime
{
    class ClasseTime
    {
        private string nome;
        private Int32 vitorias;
        private Int32 derrotas;
        private Int32 empates;
        private List<Jogador> jogadores;

        public ClasseTime(string Nome)
        {
            this.nome = Nome;
            this.vitorias = 0;
            this.derrotas = 0;
            this.empates = 0;
            this.jogadores = new List<Jogador>();
        }
        public string Nome
        {
            get { return nome; }
        }
        public string getStatus()
        {
            return "O status do Time " + this.Nome +
            " é Vitorias: " + this.Vitorias +
            "\tDerrotas: " + this.Derrotas +
            "\tEmpates: " + this.Empates;
        }

        public Int32 Vitorias
        {
            get { return vitorias; }
            set { vitorias += value; }
        }
        public Int32 Derrotas
        {
            get { return derrotas; }
            set { derrotas += value; }
        }
        public Int32 Empates
        {
            get { return empates; }
            set { empates += value; }
        }
        public void contratarJogador(Jogador J)
        {
            this.jogadores.Add(J);
        }
        private string demitirJogador(Jogador J)
        {
            int buscarJogador = this.jogadores.IndexOf(J);

            string strRetorno = "Jogador " + J.getNome();
            if (buscarJogador != -1)
            {
                this.jogadores.RemoveAt(buscarJogador);
                return strRetorno + "demitido";
            }
            return "Não foi possivel demitir " + strRetorno;
        }
        private Jogador getJogador(int camisa)
        {
            return jogadores.Find(J => J.getCamisa().Equals(camisa));
        }
        public void gol(int camisa)
        {
            this.getJogador(camisa).Gols = 1;
        }
        public void getDescricaoJogadores()
        {
            foreach(Jogador jog in jogadores)
            {
                Console.WriteLine("Nome: " +jog.getNome() + 
                                  " \tIdade: "+ jog.getIdade() +
                                  " \tHabiliade: " + jog.getHabilidade()+
                                  " \tCamisa: " + jog.getCamisa() +
                                  " \tGols: " + jog.Gols
                                   );
                
            }
        }
    }
}
