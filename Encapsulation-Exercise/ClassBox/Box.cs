using System;
using System.Collections.Generic;
using System.Text;


public class Box
{
    private decimal lenght;
    private decimal width;
    private decimal height;
    private decimal surfaceArea;
    private decimal lateralSurfaceArea;
    private decimal volume;

    public decimal Lenght
    {
        get { return lenght; }
        private set
        {
            if (value<= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");

            }
            this.lenght = value;
        }

    }


    public decimal Width
    {
        get { return width; }

        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");

            }
            this.width = value;
        }

    }



    public decimal Height
    {
        get { return height; }

        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");

            }
            this.height = value;
        }
    }

    public Box(decimal lenght, decimal width, decimal height)
    {
        this.Lenght = lenght;
        this.Width = width;
        this.Height = height;
        this.surfaceArea = 0;
        this.lateralSurfaceArea = 0;
        this.volume = 0;
    }

    public decimal CalculateSurfaceArea(decimal lenght, decimal width, decimal height)
    {
        this.surfaceArea = 2*(this.lenght * this.width)+ 2*(this.lenght * this.height) + 2*(this.width * this.height);
        return this.surfaceArea;
    }

    public decimal CalculateLateralSurfaceArea(decimal lenght, decimal width, decimal height)
    {
        this.lateralSurfaceArea = 2 * (this.lenght * this.height) + 2 * (this.width * this.height);
        return this.lateralSurfaceArea;
    }

    public decimal CalculateVolume(decimal lenght, decimal width, decimal height)
    {
        this.volume = this.lenght * this.width * this.height;
        return this.volume;
    }


}
