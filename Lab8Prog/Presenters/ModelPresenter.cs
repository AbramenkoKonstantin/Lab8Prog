﻿using System.IO;
using Lab8Prog.Views;
using Lab8Prog.Models;

namespace Lab8Prog.Presenters
{
    public class ModelPresenter
    {
        IModel modelView;

        public ModelPresenter(IModel view)
        {
            modelView = view;
        }


        public void deleteFiles()
        {
            Model model = new Model();
            model.firstPath = modelView.firstPathText;
            model.secondPath = modelView.secondPathText;
            FileInfo fileInfo1 = new FileInfo(model.firstPath);
            FileInfo fileInfo2 = new FileInfo(model.secondPath);
            if(fileInfo1.Exists && fileInfo2.Exists)
            {
                fileInfo1.Delete();
                fileInfo2.Delete();
            }
        }

        public void createFiles()
        {
            Model model = new Model();
            model.firstPath = modelView.firstPathText;
            model.secondPath = modelView.secondPathText;
            model.fileText = modelView.modifiedText;
            using (StreamWriter sw = new StreamWriter(model.firstPath))
            {
                sw.Write(model.fileText);
            }

            using (StreamWriter sw = new StreamWriter(model.secondPath))
            {
                sw.Write(model.fileText);
            }
        }

        public void changingFiles()
        {
            Model model = new Model();
            model.firstPath = modelView.firstPathText;
            model.secondPath = modelView.secondPathText;
            model.fileText = modelView.modifiedText;
            using (StreamWriter sw = new StreamWriter(model.firstPath))
            {
                sw.Write(model.fileText);
            }

            using (StreamWriter sw = new StreamWriter(model.secondPath))
            {
                sw.Write(model.fileText);
            }
        }
    }
}