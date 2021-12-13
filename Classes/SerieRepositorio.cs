using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;
namespace DIO.Series
{
	public class SerieRepositorio : IRepositorio<Serie> //implementa um repositorio de serie
	{
        private List<Serie> listaSerie = new List <Serie> (); //lista que contem todas as series
		public void Atualiza(int id, Serie entidade)
		{
			listaSerie[id] = entidade; //recebe um objeto e o coloca numa posicao do vetor de series
		}

		public void Exclui(int id)
		{
			listaSerie[id].Excluir();
		}

		public void Insere(Serie entidade)
		{
			listaSerie.Add(entidade); 
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}
	}
}