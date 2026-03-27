( Square Root )
: sqrt ( n -- sqrt )
  ( init ) dup
  ( loop ) !< 2dup / over + 2/ swap over - abs 2 <
           if drop nip -> then drop <-
;


( Fibonacci Generator )

: print 10 emit dup . ; ( -- )

: fib ( u -- )
  ( init ) >r 0 1 r>
  ( loop ) for print 2dup + rot drop next
  ( exit ) 2drop
;


( PRIME NUMBERS GENERATOR )

: ?prime ( n -- )
( init ) 10 a!
( loop ) !<
           @ if drop dup ! . -> then
           over swap mod if drop drop -> then
           drop @+ drop
         <-
;

: !prime ( u -- )
( init ) 10 a! 2 ! 3
( loop ) !< 2dup = if 2drop -> then drop
         dup ?prime 1 + <- >!
;

: count
  1 .
  2 .
  3 .
  4 .
  5 .
  6 .
  7 .
  8 .
  9 .
  10 .
  11 .
  12 .
  13 .
  14 .
  15 .
  16 .
  17 .
  18 .
  19 .
  20 .
    1 .
  2 .
  3 .
  4 .
  5 .
  6 .
  7 .
  8 .
  9 .
  10 .
  11 .
  12 .
  13 .
  14 .
  15 .
  16 .
  17 .
  18 .
  19 .
  20 .
    1 .
  2 .
  3 .
  4 .
  5 .
  6 .
  7 .
  8 .
  9 .
  10 .
  11 .
  12 .
  13 .
  14 .
  15 .
  16 .
  17 .
  18 .
  19 .
  20 .
    1 .
  2 .
  3 .
  4 .
  5 .
  6 .
  7 .
  8 .
  9 .
  10 .
  11 .
  12 .
  13 .
  14 .
  15 .
  16 .
  17 .
  18 .
  19 .
  20 .
    1 .
  2 .
  3 .
  4 .
  5 .
  6 .
  7 .
  8 .
  9 .
  10 .
  11 .
  12 .
  13 .
  14 .
  15 .
  16 .
  17 .
  18 .
  19 .
  20 .
;
