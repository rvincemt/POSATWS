<html>
  <head>
    <script type="text/javascript" src="https://www.google.com/jsapi"></script>
    <script type="text/javascript">
      google.load("visualization", "1", {packages:["map"]});
      google.setOnLoadCallback(drawChart);
      function drawChart() {
        var data = google.visualization.arrayToDataTable([
          ['Lat', 'Long', 'Name'],
          [37.4232, -122.0853, 'EDSA Orense'],
          //[37.4289, -122.1697, 'University'],
        
        ]);

        var options = {
          icons: {
            default: {
              normal: 'http://icons.iconarchive.com/icons/icons-land/vista-map-markers/48/Map-Marker-Ball-Azure-icon.png',
              selected: 'http://icons.iconarchive.com/icons/icons-land/vista-map-markers/48/Map-Marker-Ball-Right-Azure-icon.png'
            }
          }
        };

        var map = new google.visualization.Map(document.getElementById('map_markers_div'));
        map.draw(data, {showTip: true});
      }

    </script>
  </head>

  <body>
    <div id="map_markers_div" style="width: 400px; height: 300px"></div>
    <iframe width="450" height="260" style="border: 1px solid #cccccc;" src="http://api.thingspeak.com/channels/23740/charts/2?width=450&height=260&results=60&dynamic=true&xaxis=Flood%20Height&title=EDSA-Orense%20Flood" ></iframe>
  </body>
</html>