using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;


namespace DIO.Filmes
{
    public class FilmeRepositorio: IRepositorio<Filmes>
    {
        private List<Filmes> listaSerie = new List<Filmes>();
    private List<Filmes> listaFilmes;

    public void Atualiza(int id, Filmes objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaSerie[id].Excluir();
		}

		public void Insere(Filmes objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Filmes> Lista()
		{
			return listaFilmes;
		}

		public int ProximoId()
		{
			return listaFilmes.Count;
		}

		public Filmes RetornaPorId(int id)
		{
			return listaFilmes[id];
		}
	}
}