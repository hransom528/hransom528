program main
    implicit none
    logical :: a
    print *, "Test out the NOT operator by typing TRUE or FALSE!"
    read *, a
    a = .not.(a)
    print *, "Result: ", a
end program
