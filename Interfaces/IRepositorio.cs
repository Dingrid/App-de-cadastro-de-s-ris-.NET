using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T> //T é um tpo generico de classe
    {
        List<T> Lista();
        T RetornaPorId(int id);        
        void Insere(T entidade);        
        void Exclui(int id);        
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}