using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace TrackApp.Logic.Gps
{
    /// <summary>
    /// GPX file format methods
    /// </summary>
    public class GPXFileLoader : IGPSReader
    {
        private readonly List<GPSPoint> pts = new List<GPSPoint>();

        //TODO: use xml parser
        /// <summary>
        /// Reads a GPX file to GPSData
        /// </summary>
        /// <param name="path">The file path to the GPX route</param>
        public void LoadPoints(string path)
        {
            XDocument gpxDoc = XDocument.Load(path);
            XNamespace gpxNamespace = XNamespace.Get("http://www.topografix.com/GPX/1/1");

            // WHAT?
            var points = from point in gpxDoc.Descendants(gpxNamespace + "trkpt")  // trk/trkseg/trkpt
                         select new
                         {
                             Latitude = point.Attribute("lat").Value,
                             Longitude = point.Attribute("lon").Value,
                             Elevation = point.Element(gpxNamespace + "ele") != null ? point.Element(gpxNamespace + "ele").Value : null,
                             Dt = point.Element(gpxNamespace + "time") != null ? point.Element(gpxNamespace + "time").Value : null
                         };

            DateTime startTime = new DateTime();
            bool isStart = true;
            foreach (var pt in points)
            {
                if (isStart)
                {
                    startTime = System.Convert.ToDateTime(pt.Dt, CultureInfo.InvariantCulture);
                    isStart = false;
                }

                // This is where we'd instantiate data
                // containers for the information retrieved.
                this.pts.Add(new GPSPoint(
                    Convert.ToDouble(pt.Longitude, CultureInfo.InvariantCulture),
                    Convert.ToDouble(pt.Latitude, CultureInfo.InvariantCulture),
                    Convert.ToDouble(pt.Elevation, CultureInfo.InvariantCulture),
                    (float)(Convert.ToDateTime(pt.Dt, CultureInfo.InvariantCulture) - startTime).TotalSeconds, 0)); 
                ////MessageBox.Show(string.Format("Latitude:{0} Longitude:{1} Elevation:{2} Date:{3}\n", pt.Longitude, pt.Latitude, pt.Elevation, pt.Dt));
            }

            ////MessageBox.Show(pts.Count.ToString());
            GPSData.GetData().Update(this.pts);
        }
    }
}