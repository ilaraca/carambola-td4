using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

//Classe responsável pela regra de negócio da aplicação
namespace BLL
{
    public class Bll
    {
        public List<string> RetornaEstadosTratados()
        {
            List<string> listaDosEstadosTratados = new List<string>();
            Dao classeDao = new Dao();
            listaDosEstadosTratados = classeDao.RetornaListaEstado().Distinct().ToList();
            return listaDosEstadosTratados;
        }
    }
}
