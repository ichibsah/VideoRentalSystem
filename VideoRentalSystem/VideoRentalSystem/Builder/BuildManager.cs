﻿using Ninject.Modules;
using VideoRentalSystem.Commands;
using VideoRentalSystem.Commands.Contracts;
using VideoRentalSystem.Commands.Factory;
using VideoRentalSystem.Common;
using VideoRentalSystem.Common.Contracts;
using VideoRentalSystem.Core;
using VideoRentalSystem.Core.Contracts;
using VideoRentalSystem.Data;
using VideoRentalSystem.Data.Contracts;
using VideoRentalSystem.Models.Factories;

namespace VideoRentalSystem.Builder
{
    public class BuildManager : NinjectModule
    {
        public override void Load()
        {
            var consoleReader = this.Bind<IReader>().To<ConsoleReader>().InSingletonScope();
            var consoleWriter = this.Bind<IWriter>().To<ConsoleWriter>().InSingletonScope();
            var videoRentalContext = this.Bind<VideoRentalContext>().ToSelf().InSingletonScope();

            var database = this.Bind<IDatabase>().To<Database>().InSingletonScope();
            var modelFactory = this.Bind<IModelsFactory>().To<ModelsFactory>().InSingletonScope();

            this.Bind<IServiceLocator>().To<ServiceLocator>().InSingletonScope();
            var commandFactory = this.Bind<ICommandsFactory>().To<CommandsFactory>().InSingletonScope();
            var commandProcesor = this.Bind<IProcessor>().To<CommandProcessor>().InSingletonScope();

            /////Bind commands
            this.Bind<ICommand>().To<CreateCountryCommand>().Named("CreateCountry");
            this.Bind<ICommand>().To<CreateEmployeeCommand>().Named("CreateEmployee");

            var engine = this.Bind<IEngine>().To<Engine>().InSingletonScope();
        }
    }
}
