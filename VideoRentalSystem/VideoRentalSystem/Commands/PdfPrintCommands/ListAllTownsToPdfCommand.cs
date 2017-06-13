﻿using VideoRentalSystem.Commands.Contracts;
using VideoRentalSystem.Data.Contracts;
using System.Collections.Generic;

namespace VideoRentalSystem.Commands.PdfPrintCommands
{
    // <auto-generated/>
    public class ListAllTownsToPdfCommand : ICommand
    {
        private readonly string fileName = @"..\..\..\TownsList.pdf";
        private readonly string imgPath = @"..\..\..\PaperAirplane.jpg";
        private readonly string title = "Towns Report";
        private readonly string header = "Towns Report";
        private readonly string author = "Towns Bounty";
        private readonly string target = "Towns";
        private readonly string keyword = "video rental system";
        private readonly string headerRental = "video rental";
        private readonly string listName = "Towns LIST\n\n";
        private readonly string subTitle = "What Towns are in the Trible Bounty system ?";
        private readonly string warningMessage = "All Towns can be deleted without prior notice. Especially those with Mitko in them.";

        private readonly IDatabase db;
        private readonly CreatePDF pdf;

        public ListAllTownsToPdfCommand(IDatabase db, CreatePDF pdf)
        {
            this.db = db;
            this.pdf = pdf;
        }

        public void AllObjectsToStringList(List<string> data)
        {
            var objectsList = this.db.Towns.GetAll();
            if (objectsList.Count == 0)
            {
                data.Add("No items");
            }

            foreach (var item in objectsList)
            {
                data.Add(item.ToString());
            }
        }

        public string Execute(IList<string> parameters)
        {
            List<string> data = new List<string>();
            AllObjectsToStringList(data);

            pdf.CreatePdf(fileName, imgPath, title, header, target, author, keyword, headerRental, listName,
                    subTitle, warningMessage, data);

            return $"Pdf - {fileName} - with the list of all {target} was created in the project folder";
        }
    }
}