<?php
echo "<body bgcolor=#111111>";
echo "<font face=consolas size=-1 color=white>";
echo "<style>html, body {{ padding: 0; margin: 0 }}</style>";
$servername = "localhost";
$username = "root";
$password = "rootpassword";
$dbname = "detection";

$conn = new mysqli($servername, $username, $password, $dbname);
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 

$name = $_GET['cheat_name'];
$sql = "SELECT cheat_detection_status FROM cheetos WHERE cheat_name = '".$name."'";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    while($row = $result->fetch_assoc()) {
        echo "STATUS : ", $row["cheat_detection_status"];
    }
} else {
	echo "N/A";
}
$conn->close();
echo "</font>";
echo "</body>";
?>
