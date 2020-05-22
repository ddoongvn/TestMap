using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Syncfusion.SfMaps.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using Xamarin.Forms;
using Point = Xamarin.Forms.Point;

namespace TestMap.ViewModels
{
    public class MapTestViewModel : ViewModelBase
    {
        public MapTestViewModel(INavigationService navigationService) : base(navigationService)
        {
            _sublayers = new ObservableCollection<ShapeFileLayer>();
            Markers = new ObservableCollection<MapMarker>()
            {
                new MapMarker(){Latitude ="67.26238555",Longitude="-14.31983023"},
                new MapMarker(){Latitude ="67.58549159",Longitude="-11.84384661"},
                new MapMarker(){Latitude ="66.81337252",Longitude="-11.66571815"},

            };
            TestLayer();
        }
        private ObservableCollection<ShapeFileLayer> _sublayers;
        public ObservableCollection<ShapeFileLayer> Sublayers
        {
            get { return _sublayers; }
            set
            {
                SetProperty(ref _sublayers, value);
                RaisePropertyChanged();
            }
        }
        private ObservableCollection<MapMarker> _markers;
        public ObservableCollection<MapMarker> Markers
        {
            get { return _markers; }
            set
            {
                SetProperty(ref _markers, value);
                RaisePropertyChanged();
            }
        }

        private void TestLayer()
        {
            var color = Xamarin.Forms.Color.Blue;
            ShapeFileLayer subLayer = new ShapeFileLayer();
            subLayer.ShapeType = ShapeType.Polyline;
            subLayer.Points = new ObservableCollection<Xamarin.Forms.Point>()
            {
                new Point(67.26238555,-14.31983023),
                 new Point(67.58549159,-11.84384661),
                  new Point(66.81337252,-11.66571815),                 

            };
            ShapeSetting subLayerSetting = new ShapeSetting();
            subLayerSetting.ShapeFill = color.MultiplyAlpha(.3);
            subLayerSetting.ShapeStroke = color.MultiplyAlpha(.5);

            subLayerSetting.ShapeStrokeThickness = 2;
            subLayer.ShapeSettings = subLayerSetting;

            Sublayers.Add(subLayer);

        }
    }
}
