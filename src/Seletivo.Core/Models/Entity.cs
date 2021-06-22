using System;

namespace Seletivo.Core.Models
{
    /// <summary>
    /// Modelo de entidade abstrata que servirá como base para as demais entidades do sistema. 
    /// </summary>
    public abstract class Entity
    {
        public Guid Id { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
