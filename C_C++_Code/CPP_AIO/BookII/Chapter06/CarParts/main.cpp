#include <iostream>
#include "mediator.h"
#include "carparts.h"

using namespace std;

Mediator::Mediator()
{
    MyEngine = new Engine(this);
    MyElectric = new Electric(this);
    MyRadio = new Radio(this);
    MyWheels = new Wheels(this);
    MyBrakes = new Brakes(this);
    MyHeadlights = new Headlights(this);
    MyAirConditioner = new AirConditioner(this);
    MyRoad = new Road(this);
}

void Mediator::PartChanged(CarPart *part)
{
    if (part == MyEngine)
    {
        if (MyEngine->RPM == 0)
        {
            MyWheels->Speed = 0;
            return;
        }

        if (MyEngine->Revamount == 0)
        {
            return;
        }

        // If engine increases, increase the electric output
        MyElectric->ChangeOutputBy
            (MyEngine->Revamount / 10);

        if (MyEngine->Revamount > 0)
        {
            MyWheels->Accelerate(
                MyEngine->Revamount / 50);
        }
    }

    else if (part == MyElectric)
    {
        // Dim or brighten the headlights
        if (MyHeadlights->Brightness > 0)
          MyHeadlights->Adjust(MyElectric->ChangedBy / 20);

        if (MyRadio->Volume > 0)
          MyRadio->AdjustVolume(MyElectric->ChangedBy / 30);
    }

    else if (part == MyBrakes)
    {
        MyWheels->Decelerate(MyBrakes->Pressure / 5);
    }

    else if (part == MyAirConditioner)
    {
        MyElectric->ChangeOutputBy(
            0 - MyAirConditioner->ChangedBy * 2);
    }

    else if (part == MyRoad)
    {
        if (MyRoad->ClimbAngle > 0)
        {
            MyWheels->Decelerate(MyRoad->ClimbAngle * 2);
            MyRoad->ClimbAngle = 0;
        }

        else if (MyRoad->ClimbAngle < 0)
        {
            MyWheels->Accelerate(MyRoad->ClimbAngle * -4);
            MyRoad->ClimbAngle = 0;
        }
    }
}

void CarControls::StartCar()
{
    MyEngine->Start();
}

void CarControls::StopCar()
{
    MyEngine->Stop();
}

void CarControls::PushGasPedal(int amount)
{
    MyEngine->PushGasPedal(amount);
}

void CarControls::ReleaseGasPedal(int amount)
{
    MyEngine->ReleaseGasPedal(amount);
}

void CarControls::PressBrake(int amount)
{
    MyBrakes->Apply(amount);
}

void CarControls::TurnOnRadio()
{
    MyRadio->SetVolume(100);
}

void CarControls::TurnOffRadio()
{
    MyRadio->SetVolume(0);
}

void CarControls::AdjustRadioVolume(int amount)
{
    MyRadio->AdjustVolume(amount);
}

void CarControls::TurnOnHeadlights()
{
    MyHeadlights->TurnOn();
}

void CarControls::TurnOffHeadlights()
{
    MyHeadlights->TurnOff();
}

void CarControls::ClimbHill(int angle)
{
    MyRoad->ClimbDescend(angle);
}

void CarControls::DescendHill(int angle)
{
    MyRoad->ClimbDescend( 0 - angle );
}

int CarControls::GetSpeed()
{
    return MyWheels->Speed;
}

void CarControls::TurnOnAC()
{
    MyAirConditioner->TurnOn();
}

void CarControls::TurnOffAC()
{
    MyAirConditioner->TurnOff();
}

void CarControls::AdjustAC(int amount)
{
    MyAirConditioner->SetLevel(amount);
}

int main()
{
    // Create a new car.
    Mediator *MyCar = new Mediator();

    // Start the engine.
    MyCar->MyEngine->Start();
    cout << "Engine Started!" << endl;

    // Accelerate.
    MyCar->MyWheels->Accelerate(20);
    cout << "The car is going: " << MyCar->MyWheels->GetSpeed() << endl;

    // Apply the brakes.
    MyCar->MyBrakes->Apply(20);
    cout << "Applying the brakes." << endl;
    cout << "The car is going: " << MyCar->MyWheels->GetSpeed() << endl;

    // Stop the car.
    MyCar->MyBrakes->Apply(80);
    cout << "Applying the brakes." << endl;
    cout << "The car is going: " << MyCar->MyWheels->GetSpeed() << endl;

    // Shut off the engine.
    MyCar->MyEngine->Stop();
    cout << "Engine Stopped" << endl;

    return 0;
}
