import socket

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
PORT = 80

host_ip = socket.gethostbyname('www.google.com')
print(host_ip)
s.connect((host_ip, PORT))
print("Connected to Google")

s.send(b'GET / HTTP/1.1\nHost: www.google.com\n\n')
data = s.recv(4096)
s.close()
print(data.decode())