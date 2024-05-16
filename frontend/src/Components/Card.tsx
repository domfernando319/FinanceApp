type Props = {}
import "./Card.css"

const Card = (_props: Props) => {
  return (
    <div className='card'>
        <img />
        <div className="details">
            <h2>AAPL</h2>
            <p>$110</p>
        </div>
        <p className="info">lorem10</p>
    </div>
    
  )
}

export default Card