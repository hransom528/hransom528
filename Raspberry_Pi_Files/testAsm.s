.text

.global _start

_start:
	MOV R0, #0b010
	MOV R7, #1
SWI 0
