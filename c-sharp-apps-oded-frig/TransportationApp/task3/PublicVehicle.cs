﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_oded_frig.task3
{
    public class PublicVehicle
    {
        private int line = 0;
        private int id = 0;
        protected int maxSpeed = 0;
        private int currentPassengers = 0;
        private int rejecetedPassengers = 0;
        private int seats = 0;
        private bool hasRoom = true;

        #region get and set

        public int Line { get => line; set => line = value; }
        public int Id { get => id; set => id = value; }
        public int CurrentPassengers { get => currentPassengers; set => currentPassengers = value; }
        public int RejecetedPassengers { get => rejecetedPassengers; set => rejecetedPassengers = value; }
        public int Seats { get => seats; set => seats = value; }
        public bool HasRoom { get => hasRoom; set => hasRoom = value; }

        public virtual int MaxSpeed
        {
            get => this.maxSpeed;
            set
            {
                if (value <= 40)
                {
                    this.maxSpeed = value;
                }
            }
        }

        #endregion




        public PublicVehicle()
        {

        }

        public PublicVehicle(int line, int id)
        {
            this.line = line;
            this.id = id;
        }

        public PublicVehicle(int line, int id, int maxSpeed, int seats)
        {
            this.line = line;
            this.id = id;
            this.Seats = seats;
            if (maxSpeed <= 40)
                this.maxSpeed = maxSpeed;
            else this.maxSpeed = 0;

        }


        public virtual bool CalculateHasRoom()
        {
            return (this.seats - this.currentPassengers) > 0;

        }
        public virtual void UploadPassengers(int passengers)
        {
            if (!CalculateHasRoom())
            {
                Console.WriteLine("No, the vehicle is full");
                return;
            }

            if (seats >= currentPassengers + passengers)
            {
                currentPassengers += passengers;
                if (currentPassengers == seats)
                {
                    HasRoom = false;
                }
            }
            else
            {
                rejecetedPassengers = (currentPassengers + passengers) - seats;
                currentPassengers = seats;
                HasRoom = false;
            }
        }
        public override string ToString()
        {
            return $"PublicVehicle: Line={Line}, Id={Id}, MaxSpeed={MaxSpeed}, CurrentPassengers={CurrentPassengers}, Seats={Seats}";
        }
    }
}
