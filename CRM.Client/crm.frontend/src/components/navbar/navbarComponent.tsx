import { useState, useRef } from "react";
import { NavLink } from "react-router-dom";
import {
  Container,
  Navbar,
  Nav,
  Button,
  Badge,
  Overlay,
  Tooltip,
} from "react-bootstrap";
import ReactContent from "../hoc/ReactContent";
// import { useCartContext } from "../../context/CartContext";

const NavbarComponent = () => {
  const [show, setShow] = useState(false);
  const target = useRef(null);
  return (
    <ReactContent>
      <Navbar className="navbar bg-primary bg-bg-gradient rounded text-light mb-2 shadow fixed-top m-3">
        <Container fluid>
          <Nav className="">
            <Nav.Link to="/" as={NavLink} className="text-light">
              Home
            </Nav.Link>
            <Nav.Link to="/products" as={NavLink} className="text-light">
              Products
            </Nav.Link>
            <Nav.Link to="/dashboard" as={NavLink} className="text-light">
              Dashboard
            </Nav.Link>
            <Nav.Link to="/about" as={NavLink} className="text-light">
              About
            </Nav.Link>
          </Nav>
          <Button
            ref={target}
            onClick={() => {
              setShow(!show);
            }}
            className="bg-primary btn-outline-light"
            style={{
              width: "3rem",
              height: "3rem",
              position: "relative",
              fontSize: "1.2rem",
            }}
          >
            <i className="bi bi-cart"></i>
            <Badge bg="dark" text="light">
              {1}
            </Badge>
          </Button>
          <Overlay target={target.current} show={show} placement="left">
            {(props) => (
              <Tooltip id="overlay-example" {...props}>
                سبد خرید
              </Tooltip>
            )}
          </Overlay>
        </Container>
      </Navbar>
    </ReactContent>
  );
};
export default NavbarComponent;
