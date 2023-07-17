import { FC } from "react"
import { Planet } from "../models/planet"

const ViewPlanet: FC<Planet> = ( planet ) =>{
    return(
        <div>
            <div className="grid grid-cols-12">
                <div className="col-span-12 mx-auto bg-neutral-800 shadow-md mb-6 border border-4 border-slate-300 rounded-lg">
                    <img className="object-cover w-72 rounded-md" src={planet.imageUrl} alt={planet.name} />
                    <p className="text-neutral-950 bg-slate-300">
                        <h1 className="font-sans font-semibold">{planet.name}</h1>
                    </p>
                </div>
                <div className="col-start-5 my-2 col-span-2">
                    Distance from the sun (10<sup>6</sup> km)
                </div>
                <div className="text-neutral-950 rounded-md my-2 bg-slate-300">
                    {planet.distanceFromSun}
                </div>
                <div className="col-start-5 my-2 col-span-2">
                Mass (10<sup>24</sup> kg)
                </div>
                <div className="text-neutral-950 rounded-md my-2 bg-slate-300">
                    {planet.mass}
                </div>
                <div className="col-start-5 my-2 col-span-2">
                    Diameter (km)
                </div>
                <div className="text-neutral-950 rounded-md my-2 bg-slate-300">
                    {planet.diameter}
                </div>
            </div>            
        </div>
    )
}
export default ViewPlanet