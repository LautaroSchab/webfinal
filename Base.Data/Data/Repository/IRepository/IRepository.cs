﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Base.Data.Data.Repository.IRepository
{
    public   interface IRepository<T> where T : class
    {
        //INTERFACE DE REPOSITORIO GENÉRICO---SIEMPRE ES EL MISMO CODIGO
        // LA LETRA T ES UN PARAMETRO DE TIPO GENERICO
        //OBTENER UN REGISTRO POR ID
        T Get(int id);
        //OBTENER UN LISTADO CON TODOS LOS REGISTROS PUDIENDO HACER FILTRADOS
        public IEnumerable<T> GetAll(
        Expression<Func<T, bool>>? filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
        string? includeProperties = null
        );
        //OBTENER REGISTRO INDIVIDUAL
        T GetFirstOrDefault(
        Expression<Func<T, bool>>? filter = null,
        string? includeProperties = null
        );
        //DEFINIMOS LOS METODOS ALTA Y BAJA DE REGISTROS
        void Add(T entity);
        void Remove(int id);
        void Remove(T entity);
    }
}
