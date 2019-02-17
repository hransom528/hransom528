#include <iostream>
#include "boost/date_time/posix_time/posix_time.hpp"

using namespace std;
using namespace boost::posix_time;
using namespace boost::gregorian;

int main()
{
    // Obtain the current date and time.
    ptime Now = second_clock::local_time();
    cout << Now << endl;

    // Get the date and adjust it for tomorrow.
    date TheDate = Now.date() + days(1);

    // Get the time and adjust for an hour from now.
    time_duration TheHour = Now.time_of_day() + hours(1);

    // Create a new date/time and output it.
    ptime NewDateTime = ptime(TheDate, TheHour);
    cout << NewDateTime << endl;

    return 0;
}
