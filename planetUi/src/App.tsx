import PlanetList from './components/PlanetList'
import './App.css'

function App() {

  return (
    <> 
      <h1>The Solar System</h1>
      <div className='py-8 px-8'>  
        <PlanetList />
      </div>
      <div className="my-2 mt-4">
          Sources:
          <p><a className="underline decoration-teal-500" href="https://solarsystem.nasa.gov/planets/overview/">https://solarsystem.nasa.gov/planets/overview/</a></p>
          <p><a className="underline decoration-teal-500" href="https://solarsystem.nasa.gov/planets/overview/">https://nssdc.gsfc.nasa.gov/planetary/factsheet/index.html</a></p>
      </div>
    </>
  )
}

export default App
