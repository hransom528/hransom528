testAsm: testAsm.o
	ld -o testAsm testAsm.o
testAsm.o: testAsm.s
	as -o testAsm.o testAsm.s
clean:
	rm *.o testAsm

