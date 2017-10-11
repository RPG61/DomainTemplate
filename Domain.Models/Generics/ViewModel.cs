using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Generics
{
    /// <summary>
    /// A generic transport container for POCO models
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class ViewModel<TEntity> where TEntity : class
    {
        public ViewModel(TEntity entity)
        {

        }

        public TEntity Entity { get; set; }
    }
}
