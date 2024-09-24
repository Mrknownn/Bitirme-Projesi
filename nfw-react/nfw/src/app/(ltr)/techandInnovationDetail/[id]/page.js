"use client";
import TechAndInovationDetailPage from '../page'

const TechAndInovationDetail = ({ params }) => {


    if (params.id)
        return <TechAndInovationDetailPage id={params.id} />;
};

export default TechAndInovationDetail