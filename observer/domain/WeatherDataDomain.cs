class WeatherDataDomain{

    private float pressure;
    private float humidity;
    private float temperature;

    public float Pressure{
        get {  return pressure; }
    }
    public float Humidity{ 
        get {return humidity; }
    }
    public float Temperature{ 
        get {return temperature; } 
    }

    public WeatherDataDomain(float pressure,float humidity,float temperature){
        this.pressure = pressure;
        this.humidity = humidity;
        this.temperature = temperature;
    }
}