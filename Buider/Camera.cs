using System;

namespace Builder
{
    public abstract class Camera
    {
        public Camera(int megaPixels, double aperture)
        {
            MegaPixels = megaPixels;

            Aperture = aperture;
        }

        public int MegaPixels { get; set; }

        public double Aperture { get; set; }
    }
}
