import { useEffect, useState } from "react"
import { Planet } from './../models/planet'
import axios from "axios";
import ViewPlanet from "./ViewPlanet";

const PlanetList = () =>{

    const [ selectedPlanet, setSelectedPlanet ] = useState<Planet|null>(null);
    const [ planetList, setPlanetList ] = useState<Planet[]>([]);

    useEffect(()=>{
        console.log("planet set to:", selectedPlanet)
    },[selectedPlanet])
    
    useEffect(()=>{
        getPlanets();
    },[])

    const getPlanets = () =>{
       const url = import.meta.env.VITE_API_URL + "planet"
        axios.get<Planet[]>(url)
        .then((res) => {
            console.log(res)
            if(res.data.length>0){
                updatePlanetList(res.data);
            }
        })
        .catch(err => {
            alert(err);
            console.log(err);
        }) 

    }

    const updatePlanetList = (planets: Planet[]) => {
        setPlanetList(planets)
    }

    const selectPlanet = (planet: Planet) => {
        setSelectedPlanet(planet)
    }

    return (
        <>
            {planetList?.length && !selectedPlanet &&
                <p className="py-3 text-500 font-medium">
                    Click on any of the planets to discover interesting facts!
                </p>
            }
            {planetList?.map(planet =>
                <div className="planet-container inline-flex" style={{ display: selectedPlanet? 'none':''}} onClick={() => selectPlanet(planet)}>
                    <div className='flex planet-card'>
                        <div className="w-6/7 py-8 px-8 max-w-sm mx-auto bg-white rounded-xl shadow-lg space-y-2 mx-2 md:my-2 sm:py-4 sm:flex sm:items-center sm:space-y-0 sm:space-x-6 hover:bg-sky-700  active:bg-sky-300">
                        <div className="text-center space-y-2 sm:text-left">
                            <img className="block mx-auto h-24 rounded-full sm:mx-0 sm:shrink-0" src={planet.imageUrl} alt={planet.name} />
                            <div className="space-y-0.5">
                            <p className="text-lg text-center text-black font-semibold">
                                <span key={planet.id}> {planet.name} </span>
                            </p>                            
                            </div>                            
                        </div>
                        </div>
                    </div>
                </div>
            )}

            {selectedPlanet && 
                <>
                        <ViewPlanet
                            id={selectedPlanet.id}
                            name={selectedPlanet.name}
                            imageUrl={selectedPlanet.imageUrl}
                            distanceFromSun={selectedPlanet.distanceFromSun}
                            mass={selectedPlanet.mass}
                            diameter={selectedPlanet.diameter}
                            AdditionalInformation={selectedPlanet.AdditionalInformation}
                        />
                    <p className="mt-3">
                        <button onClick={() => setSelectedPlanet(null)}>◀ Back to list</button>
                    </p>
                </>

            }
            
            {!planetList.length && 
                <>
                No planets found <button onClick={getPlanets}>Reload</button>
                </>
            } 
        </>
    )

    
}

export default PlanetList;