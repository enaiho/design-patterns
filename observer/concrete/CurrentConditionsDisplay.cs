class CurrentConditionsDisplay:IObserver,IDisplayElement{

    private WeatherData weatherData;
    private float pressure;
    private float humidity;
    private float temperature;
    public CurrentConditionsDisplay(WeatherData weatherData){
        this.weatherData = weatherData;
        this.weatherData.addObserver(this);
    }
    public void update(WeatherDataDomain data){
        this.pressure = data.Pressure;
        this.humidity = data.Humidity;
        this.temperature = data.Temperature;
        show();
    }
    public void unsubscribe(){
        throw new NotImplementedException("do not implement yet");
    }
    public void show(){
        Console.WriteLine( " The current conditions are as follows : \n Temperature: {0} \n Pressure: {1} \n Humidity: {2} ", 
        temperature,pressure,humidity);
    }

}

