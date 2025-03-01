class WeatherData:IObservable {

    private float pressure;
    private float humidity;
    private float temperature;
    private List< IObserver> observers;

    public WeatherData(){
        this.observers = new List<IObserver>();
    }
    public void addObserver(IObserver observer){
        this.observers.Add( observer );
    }
    public void removeObserver(IObserver observer){
        this.observers.Remove(observer);
    }
    public void notifyObservers(){
        foreach( IObserver observer in observers ){
            observer.update( new WeatherDataDomain( this.pressure,this.humidity,this.temperature ) );
        }
    }
    public void measurementsChanged(){
        notifyObservers();
    }

    public void setMeasurementsChanged(WeatherDataDomain weatherDataDomain){
        this.pressure = weatherDataDomain.Pressure;
        this.humidity = weatherDataDomain.Humidity;
        this.temperature = weatherDataDomain.Temperature;
        measurementsChanged();
    }
}