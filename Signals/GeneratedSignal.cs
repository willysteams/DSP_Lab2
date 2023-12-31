﻿using System.ComponentModel;
using System.Drawing;

namespace DSP_lab2.Signals
{
    public abstract class GeneratedSignal : INotifyPropertyChanged
    {
        protected float phi0;
        protected float f;
        protected float a;
        protected float? d;

        public float Phi0
        {
            get => phi0;
            set
            {
                phi0 = value;
                OnPropertyChanged(nameof(Phi0));
            }
        }
        public float F
        {
            get => f;
            set
            {
                f = value;
                OnPropertyChanged(nameof(F));
            }
        }
        public float A
        {
            get => a;
            set
            {
                a = value;
                OnPropertyChanged(nameof(A));
            }
        }

        public float? D
        {
            get => d;
            set
            {
                d = value;
                OnPropertyChanged(nameof(A));
            }
        }

        public abstract SignalTypes SignalType { get; set; }

        public GeneratedSignal(float phi0, float f, float a)
        {
            this.phi0 = phi0;
            this.f = f;
            this.a = a;
        }

        public abstract PointF[] Generate(float Phi0, float A, float f, int N, float? d = null);

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
