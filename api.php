<?php
header("Content-Type: application/json");
include 'db.php';

$method = $_SERVER['REQUEST_METHOD'];
$endpoint = $_GET['endpoint'];

switch($method) {
    case 'GET':
        if ($endpoint == 'accounts') {
            $sql = "SELECT * FROM accounts";
            $result = $conn->query($sql);
            $data = [];
            while($row = $result->fetch_assoc()) {
                $data[] = $row;
            }
            echo json_encode($data);
        } elseif ($endpoint == 'users') {
            $sql = "SELECT * FROM users";
            $result = $conn->query($sql);
            $data = [];
            while($row = $result->fetch_assoc()) {
                $data[] = $row;
            }
            echo json_encode($data);
        }
        break;
    case 'POST':
        $input = json_decode(file_get_contents('php://input'), true);
        if ($endpoint == 'accounts') {
            $name = $input['name'];
            $username = $input['username'];
            $password = password_hash($input['password'], PASSWORD_BCRYPT); //SECURE PASSWORD
            $email = $input['email'];
            $sql = "INSERT INTO accounts (name, username, password, email) VALUES ('$name', '$username', '$password', '$email')";
            if ($conn->query($sql) === TRUE) {
                echo json_encode(["message" => "New account created successfully"]);
            } else {
                echo json_encode(["message" => "Error: " . $conn->error]);
            }
        } elseif ($endpoint == 'users') {
            $name = $input['name'];
            $username = $input['username'];
            $sql = "INSERT INTO users (name, username) VALUES ('$name', '$username')";
            if ($conn->query($sql) === TRUE) {
                echo json_encode(["message" => "New user created successfully"]);
            } else {
                echo json_encode(["message" => "Error: " . $conn->error]);
            }
        }
        break;
}

$conn->close();
?>
