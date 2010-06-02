﻿using StructureMap;

namespace Relax.Impl.Commands
{
    public class CouchCommandFactory 
    {
        protected TCommand GetCommand<TCommand>()
        {
            return ObjectFactory.GetInstance<TCommand>();
        }

        public AttachmentCommand GetAttachmentCommand()
        {
            return GetCommand<AttachmentCommand>();
        }

        public DeleteDocumentCommand GetDeleteCommand()
        {
            return GetCommand<DeleteDocumentCommand>();
        }

        public GetDocumentCommand GetGetDocumentCommand()
        {
            return GetCommand<GetDocumentCommand>();
        }

        public GetDocumentsCommand GetGetDocumentsCommand()
        {
            return GetCommand<GetDocumentsCommand>();
        }

        public GetFromViewCommand GetViewCommand()
        {
            return GetCommand<GetFromViewCommand>();
        }

        public SaveDocumentCommand GetSaveCommand()
        {
            return GetCommand<SaveDocumentCommand>();
        }

        public ServerCommand GetServerCommand()
        {
            return GetCommand<ServerCommand>();
        }

        public ChangeStreamCommand GetStreamCommand()
        {
            return GetCommand<ChangeStreamCommand>();
        }

        public CouchCommandFactory()
        {
        }
    }
}