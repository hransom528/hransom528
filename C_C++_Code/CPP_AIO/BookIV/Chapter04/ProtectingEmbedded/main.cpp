#include <iostream>
using namespace std;

class EthicalCompetition {
private:
    class Connection;
public:
    void HardWork();
};
class EthicalCompetition::Connection {
protected:
    friend class EthicalCompetition;
    void Connect();
    Connection() {}
    ~Connection() {}
};
void EthicalCompetition::HardWork() {
    Connection c;
    c.Connect();
    cout << "Connected" << endl;
}
void EthicalCompetition::Connection::Connect() {
    cout << "Connecting..." << endl;
}
int main(int argc, char *argv[])
{
    // EthicalCompetition::Connection myconnect;
    EthicalCompetition comp;
    comp.HardWork();
    return 0;
}

