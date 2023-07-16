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
            {planetList?.map(planet =>
                <div className="planet-container" style={{ display: selectedPlanet? 'none':''}} onClick={() => selectPlanet(planet)}>
                    <span key={planet.id}> {planet.name} </span>
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
                    <button onClick={() => setSelectedPlanet(null)}>Back to list</button>
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