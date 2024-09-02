import { Routes, Route } from "react-router-dom";
import { Container } from "react-bootstrap";
import ReactContent from "./components/hoc/ReactContent";
import HomeComponent from "./pages/layout/home/HomeComponent";
import AboutComponent from "./pages/layout/about/AboutComponent";
import NotFoundComponent from "./pages/layout/responsePage/404";
import UnauthorizePage from "./pages/layout/responsePage/401";
import ForbiddenPage from "./pages/layout/responsePage/403";
import InternalServerErrorPage from "./pages/layout/responsePage/500";
import NavbarComponent from "./components/navbar/navbarComponent";

function App() {
  // const [count,setCount] = useState(0);
  return (
    <ReactContent>
      <NavbarComponent />
      <Container
        fluid
        style={{
          marginTop: "100px",
        }}
      >
        <Routes>
          <Route path="/" element={<HomeComponent />} />
          <Route path="/about" element={<AboutComponent />} />
          <Route path="/Unauthorize" element={<UnauthorizePage />} />
          <Route path="/Forbidden" element={<ForbiddenPage />} />
          <Route
            path="/InternalServerError"
            element={<InternalServerErrorPage />}
          />
          <Route path="*" element={<NotFoundComponent />} />
        </Routes>
      </Container>
    </ReactContent>
  );
}

export default App;
