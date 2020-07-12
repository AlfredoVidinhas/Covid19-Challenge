using Covid19.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Covid19.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ObservableCollection<Card> items;
        public ObservableCollection<Card> Items
        {
            get { return items; }
            set { SetProperty(ref items, value); }
        }

        private int currentIndex;
        public int CurrentIndex
        {
            get { return currentIndex; }
            set { SetProperty(ref currentIndex, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Items = new ObservableCollection<Card>
            {
                new Card { Titulo = "Fique em casa", Descricao = "Saia de casa apenas se necessário", Animacao = "home.json" },
                new Card { Titulo = "Lave as mãos", Descricao = " Lave frequentemente as mãos.\nUtilize água e sabão, ou uma\nsolução à base de álcool.", Animacao = "wash.json" },
                new Card { Titulo = "Se sentir os síntomas", Descricao = "Se tiver febre, tosse e dificuldade\nrespiratória, procure assistência\nmédica. Ligue antes de sair.", Animacao = "sick.json" }
            };
        }
    }
}
