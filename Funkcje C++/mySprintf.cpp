// QString mySprintf(format, arguments);
// use: s = mySprintf("Its %d %s .",12,"May");
//      s = "12 May .";

template<typename ... Args>
QString mySprintf(const char * format,Args ... a)
{
    char scream[255];
    sprintf(scream,format,a ...);
    return scream;
}
