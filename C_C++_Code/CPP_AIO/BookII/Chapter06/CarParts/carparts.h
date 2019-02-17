#ifndef CARPARTS_H_INCLUDED
#define CARPARTS_H_INCLUDED

#include "mediator.h"

class CarControls; // forward reference

class CarPart
{
protected:
    Mediator *mediator;
    CarPart(Mediator *med) : mediator(med) {}
    void Changed();
};

class Engine : public CarPart
{
protected:
    friend class Mediator; friend class CarControls;
    int RPM;
    int Revamount;

public:
    Engine(Mediator *med) : CarPart(med),
        RPM(0), Revamount(0) {}
    void Start();
    void PushGasPedal(int amount);
    void ReleaseGasPedal(int amount);
    void Stop();
};

class Electric : public CarPart
{
protected:
    friend class Mediator; friend class CarControls;
    int Output;
    int ChangedBy;

public:
    Electric(Mediator *med) : CarPart(med),
        Output(0), ChangedBy(0) {}
    void ChangeOutputBy(int amount);
};

class Radio : public CarPart
{
protected:
    friend class Mediator; friend class CarControls;
    int Volume;

public:
    Radio(Mediator *med) : CarPart(med),
        Volume(0) {}
    void AdjustVolume(int amount) { Volume += amount; }
    void SetVolume(int amount) { Volume = amount; }
    int GetVolume() { return Volume; }
};

class Wheels : public CarPart
{
protected:
    friend class Mediator; friend class CarControls;
    int Speed;

public:
    Wheels(Mediator *med) : CarPart(med),
        Speed(0) {}
    int GetSpeed() { return Speed; }
    void Accelerate(int amount);
    void Decelerate(int amount);
};

class Brakes : public CarPart
{
protected:
    friend class Mediator; friend class CarControls;
    int Pressure;

public:
    Brakes(Mediator *med) : CarPart(med),
        Pressure(0) {}
    void Apply(int amount);
};

class Headlights : public CarPart
{
protected:
    friend class Mediator; friend class CarControls;
    int Brightness;

public:
    Headlights(Mediator *med) : CarPart(med),
        Brightness(0) {}
    void TurnOn() { Brightness = 100; }
    void TurnOff() { Brightness = 0; }
    void Adjust(int Amount);
    int GetBrightness() { return Brightness; }
};

class AirConditioner : public CarPart
{
protected:
    friend class Mediator; friend class CarControls;
    int Level;
    int ChangedBy;

public:
    AirConditioner(Mediator *med) : CarPart(med),
        Level(0), ChangedBy(0) {}
    void TurnOn();
    void TurnOff();
    bool GetLevel() { return Level; }
    void SetLevel(int level);
};

class Road : public CarPart
{
protected:
    friend class Mediator; friend class CarControls;
    int ClimbAngle;
    int BumpHeight;
    int BumpWhichTire;

public:
    Road(Mediator *med) : CarPart(med) {}
    void ClimbDescend(int angle);
    void Bump(int height, int which);
};

#endif
