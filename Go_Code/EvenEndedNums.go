package main

import (
	"fmt"
	"strconv"
)

func main() {
	var count uint32 = 0

	for i := 1000; i <= 9999; i++ {
		for j := i; j <= 9999; j++ {
			x := i * j
			s := strconv.Itoa(x)

			// Checks for even-endedness
			if s[0] == s[len(s)-1] {
				count++
			}
		}
	}

	fmt.Printf("# of 4-Digit Even-Ended Integers: %d\n", count)
}
