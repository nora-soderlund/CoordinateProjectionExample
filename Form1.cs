using CoordinateProjectionExample.Properties;

namespace CoordinateProjectionExample {
    internal class Coordinate {
        public float Latitude;
        public float Longitude;

        public Coordinate() { }

        public Coordinate(float latitude, float longitude) {
            Latitude = latitude;
            Longitude = longitude;
        }

    }

    internal class CoordinateBounds {
        public float West;
        public float North;
        public float East;
        public float South;

        public Coordinate GetCoordinateOffsets(Coordinate coordinate) {
            return new() {
                Latitude = North - coordinate.Latitude,
                Longitude = coordinate.Longitude - West
            };
        }

        public Coordinate GetCoordinateDifference() {
            return new Coordinate() {
                Latitude = North - South,
                Longitude = East - West
            };
        }
    }

    public partial class Form1 : Form {
        private readonly CoordinateBounds staticMapBounds = new () {
            East = 153.32191748046876f,
            North = -33.50848555239759f,
            South = -35.27618036073599f,
            West = 147.96608251953126f
        };

        private Coordinate sydneyCoordinates = new (-33.86883898636453f, 151.20914864607147f);

        public Form1() {
            InitializeComponent();

            Coordinate sydneyOffsets = staticMapBounds.GetCoordinateOffsets(sydneyCoordinates);
            MessageBox.Show($"Offsets are Lat {sydneyOffsets.Latitude} Lng {sydneyOffsets.Longitude}");

            Coordinate staticMapDifference = staticMapBounds.GetCoordinateDifference();

            MessageBox.Show($"Difference is Lat {staticMapDifference.Latitude} Lng {staticMapDifference.Longitude}");
            MessageBox.Show($"Size is width {staticMap.Width} height {staticMap.Height}");

            float widthPerLongitude = staticMap.Width / staticMapDifference.Longitude;
            float heightPerLatitude = staticMap.Height / staticMapDifference.Latitude;
            
            MessageBox.Show($"Multiplier is widthPerLng {widthPerLongitude} heightPerLat {heightPerLatitude}");

            int left = (int)(widthPerLongitude * sydneyOffsets.Longitude);
            int top = (int)(heightPerLatitude * sydneyOffsets.Latitude);

            MessageBox.Show($"Position is left {left} top {top}");

            Image image = new Bitmap(staticMap.Width, staticMap.Height);

            using (var graphics = Graphics.FromImage(image)) {
                graphics.DrawImage(Resources.static_map, new Rectangle(0, 0, staticMap.Width, staticMap.Height));
                graphics.DrawImage(Resources.pin, new Rectangle(left, top - 20, 20, 20));
            }

            staticMap.Image = image;
        }
    }
}