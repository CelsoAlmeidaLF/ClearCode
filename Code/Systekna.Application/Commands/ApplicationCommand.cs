﻿using Systekna.Core.Entity;
using Systekna.Infrasctruture.Repository;
using Systekna.Querys;

namespace Systekna.Commands
{
    public class ApplicationCommand<Entity>(IDbRepositoryCommand<Entity> db)
    : AbstractApplicationCommand<Entity>(db), IApplicationCommand<Entity> where Entity : EntityCommand, new()
    {
        public override IEnumerable<Entity> GetAll(Entity entity) => (List<Entity>)new ConsultaApplicationQuery<Entity>(db, entity);
    }
}