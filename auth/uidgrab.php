<?php
echo "<body bgcolor=#111111>";
echo "<font face=consolas size=-1 color=white>";
echo "<style>html, body {{ padding: 0; margin: 0 }}</style>";
$servername = "localhost";
$username = "root";
$password = "EffeX2002";
$dbname = "forum";

$conn = new mysqli($servername, $username, $password, $dbname);
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 

$username = "";
$user = $_GET['username'];
$sql = "SELECT uid FROM users WHERE username = '".$user."'";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    while($row = $result->fetch_assoc()) {
        echo "UID : ", $row["uid"];
    }
} else {
	header("Location: empty.php");
}
$conn->close();
echo "</font>";
echo "</body>";
?>
