import sys 

if (sys.platform == 'win32'):
	print('Hello, Windows User!')
elif (sys.platform == 'linux'):
	print('Greetings, Linux Geek!')
elif (sys.platform == 'darwin'):
	print('Ew, a Mac User!')


input('Press ENTER to close...')

