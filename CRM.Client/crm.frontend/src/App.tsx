import React from "react"; // { useState }
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import HomeComponent from "./Pages/Layout/Home/HomeComponent";
import AboutComponent from "./Pages/Layout/About/AboutComponent";
import NotFoundComponent from "./Pages/Layout/NotFound/NotFoundComponent";
// import reactLogo from "./assets/react.svg";
// import viteLogo from "/vite.svg";
import "./App.css";

function App() {
  // const [count,setCount] = useState(0);
  return (
    <React.Fragment>
      <Router>
        <Routes>
          <Route path="/" element={<HomeComponent />} />
          <Route path="/about" element={<AboutComponent />} />
          <Route path="*" element={<NotFoundComponent />} />
        </Routes>
      </Router>
    </React.Fragment>
  );
}

export default App;
