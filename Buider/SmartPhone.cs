using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class SmartPhone // Product
    {
        List<Camera> Cameras = new List<Camera>();

        public Battery Battery { get; set; }

        public OS OS { get; set; }

        public bool NFC { get; set; }

        public void AddCameras(Camera camera)
        {
            Cameras.Add(camera);
        }
    }
}
