#!/usr/bin/env pybricks-micropython
from pybricks import ev3brick as brick
from pybricks.ev3devices import (Motor, TouchSensor, ColorSensor,
                                 InfraredSensor, UltrasonicSensor, GyroSensor)
from pybricks.parameters import (Port, Stop, Direction, Button, Color,
                                 SoundFile, ImageFile, Align)
from pybricks.tools import print, wait, StopWatch
from pybricks.robotics import DriveBase

# Write your program here
count = 0
cs = ColorSensor(Port.S2)
cs.mode = 'COL-COLOR'
infra = InfraredSensor(Port.S4)
lm = Motor(Port.B, Direction.CLOCKWISE)
rm = Motor(Port.C, Direction.CLOCKWISE)
servo = Motor(Port.A, Direction.COUNTERCLOCKWISE)
robot = DriveBase(lm, rm, 20, 180)
servo.reset_angle(0)

servo.run_target(40, 70, Stop.BRAKE, True)
robot.drive(12, 0)
wait(3000)
robot.stop(Stop.BRAKE)
servo.run_target(40, 0, Stop.BRAKE, True)
robot.drive(-12, 0)
wait(3000)
robot.stop(Stop.BRAKE)
