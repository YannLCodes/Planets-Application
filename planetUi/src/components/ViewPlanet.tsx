import { FC } from "react"
import { Planet } from "../models/planet"

const ViewPlanet: FC<Planet> = ( planet ) =>{
    return(
        <>
            <h2>You are viewing {planet.name}</h2>
            <div>
                <p>Distance from the sun (10<sup>6</sup> km): {planet.distanceFromSun}</p>
                <p>Mass (10<sup>24</sup> kg): {planet.mass}</p>
                <p>Diameter: {planet.diameter} km</p>
            </div>

            <div>
                sources:
                <p>https://solarsystem.nasa.gov/planets/overview/</p>
                <p>https://nssdc.gsfc.nasa.gov/planetary/factsheet/index.html</p>
            </div>

        </>
    )
}
export default ViewPlanet